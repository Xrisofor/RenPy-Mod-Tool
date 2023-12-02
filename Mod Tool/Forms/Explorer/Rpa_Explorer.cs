using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RPA_Parser;
using LibVLCSharp.Shared;

namespace ModTool.Forms.Explorer
{
    public partial class Rpa_Explorer : Form
    {
        private RpaParser rpaParser;

        private readonly List<string> expandedList = new List<string>();
        private readonly Dictionary<string, long> indexPathSize = new Dictionary<string, long>();

        private readonly LibVLC libVlc;
        private MemoryStream memoryStreamVlc;
        private StreamMediaInput streamMediaInputVlc;
        private Media mediaVlc;

        private string defFileOpen = string.Empty;

        public Rpa_Explorer()
        {
            InitializeComponent();

            Core.Initialize();
            libVlc = new LibVLC("--input-repeat=9999999");
            videoView1.MediaPlayer = new MediaPlayer(libVlc);
            videoView1.MediaPlayer.Volume = 50;
            videoView1.MediaPlayer.TimeChanged += videoView1_MediaPlayer_TimeChanged;
            videoView1.BackgroundImage = null;
            SetMediaTimeLabel(0, 0);

            ImageList imageList = new ImageList();
            imageList.Images.Add(Resources.Resource_RPA.folder_rpa);
            imageList.Images.Add(Resources.Resource_RPA.file_rpa);
            imageList.Images.Add(Resources.Resource_RPA.file_changed_rpa);
            rpaTreeView.ImageList = imageList;

            LoadArchive($@"{FManager.GetGameFolder()}\archive.rpa");
        }

        public Rpa_Explorer(string fileOpen)
        {
            InitializeComponent();

            defFileOpen = fileOpen;

            Core.Initialize();
            libVlc = new LibVLC("--input-repeat=9999999");
            videoView1.MediaPlayer = new MediaPlayer(libVlc);
            videoView1.MediaPlayer.Volume = 50;
            videoView1.MediaPlayer.TimeChanged += videoView1_MediaPlayer_TimeChanged;
            videoView1.BackgroundImage = null;
            SetMediaTimeLabel(0, 0);

            ImageList imageList = new ImageList();
            imageList.Images.Add(Resources.Resource_RPA.folder_rpa);
            imageList.Images.Add(Resources.Resource_RPA.file_rpa);
            imageList.Images.Add(Resources.Resource_RPA.file_changed_rpa);
            rpaTreeView.ImageList = imageList;

            LoadArchive($@"{FManager.GetGameFolder()}\archive.rpa");
        }

        #region Other | Region
        private string NormalizeTreePath(string path)
        {
            return Regex.Replace(path, "^/+", "");
        }

        private void videoView1_MediaPlayer_TimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
        {
            if (videoView1.MediaPlayer?.Media != null)
            {
                SetMediaTimeLabel(videoView1.MediaPlayer.Media.Duration, e.Time);
            }
        }

        private void MarkChanged(TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Parent.ForeColor = Color.Green;
                MarkChanged(node.Parent);
            }
        }
        #endregion

        private void LoadArchive(string openFile)
        {
            expandedList.Clear();

            rpaParser = new RpaParser();
            rpaParser.PythonLocation = $@"{FManager.GetLibFolder()}\python.exe";
            rpaParser.LoadArchive(openFile);

            GenerateTreeView();
        }

        private void GenerateTreeView()
        {
            rpaTreeView.Nodes.Clear();
            indexPathSize.Clear();

            TreeNode root = new TreeNode();
            TreeNode node;

            root.Name = "";
            root.Text = @"/";
            root.ImageIndex = 0;

            rpaTreeView.Nodes.Add(root);
            indexPathSize.Add("", 0);

            string pathBuild;

            foreach (KeyValuePair<string, RpaParser.ArchiveIndex> kvp in rpaParser.Index)
            {
                node = root;
                pathBuild = String.Empty;
                foreach (string pathBits in kvp.Key.Split('/'))
                {
                    if (pathBuild == String.Empty)
                    {
                        pathBuild = pathBits;
                    }
                    else
                    {
                        pathBuild += "/" + pathBits;
                    }

                    if (node.Nodes.ContainsKey(pathBits))
                    {
                        node = node.Nodes[pathBits];
                    }
                    else
                    {
                        if (pathBuild != kvp.Key)
                        {
                            node = node.Nodes.Add(pathBits, pathBits);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, RpaParser.ArchiveIndex> kvp in rpaParser.Index)
            {
                node = root;
                pathBuild = String.Empty;
                foreach (string pathBits in kvp.Key.Split('/'))
                {
                    if (pathBuild == String.Empty)
                    {
                        pathBuild = pathBits;
                    }
                    else
                    {
                        pathBuild += "/" + pathBits;
                    }

                    node = node.Nodes.ContainsKey(pathBits) ? node.Nodes[pathBits] : node.Nodes.Add(pathBits, pathBits);

                    if (pathBuild != kvp.Key)
                    {
                        if (!indexPathSize.ContainsKey(pathBuild))
                        {
                            indexPathSize.Add(pathBuild, 0);
                        }

                        if (rpaParser.Index.ContainsKey(kvp.Key))
                        {
                            indexPathSize[pathBuild] += rpaParser.Index[kvp.Key].Length;
                        }
                    }
                    else
                    {
                        indexPathSize[""] += rpaParser.Index[kvp.Key].Length;
                    }
                }
            }

            foreach (TreeNode nodeVisuals in rpaTreeView.Nodes.All())
            {
                string nodeName = NormalizeTreePath(nodeVisuals.FullPath);

                if (nodeName != string.Empty)
                {
                    if (nodeVisuals.Nodes.Count > 0)
                    {
                        nodeVisuals.ImageIndex = 0;
                        nodeVisuals.SelectedImageIndex = 0;
                    }
                    else
                    {
                        nodeVisuals.ImageIndex = 1;
                        nodeVisuals.SelectedImageIndex = 1;
                    }
                }

                if (rpaParser.Index.ContainsKey(nodeName))
                {
                    if (!rpaParser.Index[nodeName].InArchive)
                    {
                        nodeVisuals.ImageIndex = 2;
                        nodeVisuals.SelectedImageIndex = 2;

                        MarkChanged(nodeVisuals);
                    }
                }

                if (expandedList.Contains(nodeVisuals.FullPath))
                {
                    nodeVisuals.Expand();
                }

            }

            root.Expand();

            if (defFileOpen != string.Empty)
            {
                foreach (TreeNode nodeTp in rpaTreeView.Nodes.All())
                {
                    if (nodeTp.Text == defFileOpen)
                        rpaTreeView.SelectedNode = nodeTp;
                }
            }
            else
                rpaTreeView.SelectedNode = null;
        }

        private void rpaTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PreviewSelectedItem();
        }

        private void SetMediaTimeLabel(long totalTimeMillies, long currentTimeMillies)
        {
            TimeSpan totalTime = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(totalTimeMillies));
            TimeSpan currentTime = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(currentTimeMillies));
            TimeSpan remainingTime = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(totalTimeMillies - currentTimeMillies));

            string timeFormat = "hh':'mm':'ss'.'f";
            string timeText = currentTime.ToString(timeFormat) + " / " + totalTime.ToString(timeFormat) + " (-" + remainingTime.ToString(timeFormat) + ")";
            if (videoTimeLabel.InvokeRequired)
            {
                try
                {
                    videoTimeLabel.PerformSafely(() => videoTimeLabel.Text = timeText);
                }
                catch
                {
                    // Ignored for now?
                }
            }
            else
            {
                videoTimeLabel.Text = timeText;
            }
        }

        private void ResetPreviewFields()
        {
            pictureBox1.BackgroundImage = null;
            if (memoryStreamVlc != null)
            {
                memoryStreamVlc.Dispose();
                memoryStreamVlc = null;
            }
            if (streamMediaInputVlc != null)
            {
                streamMediaInputVlc.Dispose();
                streamMediaInputVlc = null;
            }
            if (mediaVlc != null)
            {
                mediaVlc.Dispose();
                mediaVlc = null;
            }
            if (videoView1.MediaPlayer.IsPlaying == true)
            {
                //videoView1.MediaPlayer.Stop(); // Causes problems with volume
                videoView1.MediaPlayer.Play(null);
            }
            SetMediaTimeLabel(0, 0);
        }

        private void PreviewSelectedItem()
        {
            TreeNode selectedNode = new TreeNode();

            foreach (TreeNode node in rpaTreeView.Nodes.All())
            {
                ResetPreviewFields();
                tabControl1.SelectedTab = tabPage1;

                if (node.IsSelected)
                {
                    selectedNode = node;
                }

                if (node.IsSelected && rpaParser.Index.ContainsKey(NormalizeTreePath(node.FullPath)))
                {
                    KeyValuePair<string, object> data = new KeyValuePair<string, object>();
                    try
                    {
                        try
                        {
                            data = rpaParser.GetPreview(NormalizeTreePath(node.FullPath));
                        }
                        catch (Exception ex)
                        {
                            FileInfo fileInfo = new FileInfo(NormalizeTreePath(node.FullPath));
                            if (((IList)rpaParser.CodeExtList).Contains(fileInfo.Extension.ToLower()))
                            {
                                if (ex.Message.StartsWith(rpaParser.rpycInfoBanner))
                                {
                                    data = new KeyValuePair<string, object>(RpaParser.PreviewTypes.Text,
                                        string.Format("Loading preview failed with error: {0} Use 'Options' to define external locations for this preview.", ex.Message));
                                }
                                else
                                {
                                    throw;
                                }
                            }
                        }

                        var node_pt = Path.GetExtension(NormalizeTreePath(node.FullPath));
                        if (node_pt != ".rpyc" && node_pt != ".rpyb" && node_pt != ".rpym" && node_pt != ".rpymc") { }
                        else
                        {
                            MessageBox.Show("Game scripts are forbidden to open, if you really want to try RPA Extractor Online or unrpyc!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        if (data.Key == RpaParser.PreviewTypes.Image)
                        {
                            pictureBox1.BackgroundImage = (Image)data.Value;
                            tabControl1.SelectedTab = tabPage2;
                        }
                        else if (data.Key == RpaParser.PreviewTypes.Text)
                        {
                            fastColoredTextBox1.Text = (string)data.Value;
                            tabControl1.SelectedTab = tabPage3;
                        }
                        else if (data.Key == RpaParser.PreviewTypes.Audio || data.Key == RpaParser.PreviewTypes.Video)
                        {
                            memoryStreamVlc = new MemoryStream((byte[])data.Value);
                            streamMediaInputVlc = new StreamMediaInput(memoryStreamVlc);
                            mediaVlc = new Media(libVlc, streamMediaInputVlc);
                            SetMediaTimeLabel(mediaVlc.Duration, 0);
                            if (videoView1.MediaPlayer != null) videoView1.MediaPlayer.Play(mediaVlc);
                            videoView1.BackgroundImage = data.Key == RpaParser.PreviewTypes.Audio
                                ? Resources.Resource_RPA.music
                                : null;
                            tabControl1.SelectedTab = tabPage4;
                        }
                        else if (data.Key == RpaParser.PreviewTypes.Unknown)
                            tabControl1.SelectedTab = tabPage1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            string.Format("Loading preview failed with following error: {0}", ex.Message),
                            "Preview load failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                }
            }
        }

        private void Rpa_Explorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoView1.MediaPlayer != null) videoView1.MediaPlayer.Play(null);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }
    }

    public static class CrossThreadExtensions
    {
        public static void PerformSafely(this Control target, Action action)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void PerformSafely<T1>(this Control target, Action<T1> action, T1 parameter)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action, parameter);
            }
            else
            {
                action(parameter);
            }
        }

        public static void PerformSafely<T1, T2>(this Control target, Action<T1, T2> action, T1 p1, T2 p2)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action, p1, p2);
            }
            else
            {
                action(p1, p2);
            }
        }
    }

    public static class Extensions
    {
        public static IEnumerable<TreeNode> All(this TreeNodeCollection nodes)
        {
            foreach (TreeNode n in nodes)
            {
                yield return n;
                foreach (TreeNode child in n.Nodes.All())
                    yield return child;
            }
        }
    }
}
