using _1911147_Baitapcodemo_buoi3.Components;
using _1911147_Baitapcodemo_buoi3.MoDels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_Baitapcodemo_buoi3
{
    public partial class MainForm : Form
    {
        private readonly NewsFeedManager _newsManager;
        public MainForm(NewsFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }     

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(_newsManager.GetNewsFeed());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddFeedForm(_newsManager);
            dialog.ShowDialog(this);
            if(dialog.HasChanges)
            {
                _newsManager.SaveChanges();
                ShowFeedOnTreeView(_newsManager.GetNewsFeed());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tvwPublisher.SelectedNode == null) return;
            if(tvwPublisher.SelectedNode.Level == 0)
            {
                _newsManager.RemovePublisher(tvwPublisher.SelectedNode.Text);
            }
            else
            {
                var publisherNode = tvwPublisher.SelectedNode.Parent;
                _newsManager.RemoveCategory(publisherNode.Text, tvwPublisher.SelectedNode.Text);
            }
            tvwPublisher.SelectedNode.Remove();
        }

        private void tvwPublisher_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnlNews.Controls.Clear();

            if(e.Node.Level == 1)
            {
                var articles = _newsManager.GetNews(e.Node.Parent.Text, e.Node.Text);
                foreach(var article in articles)
                {
                    var item = new NewsControl();
                    item.Size = new Size(500, 100);
                    item.Dock = DockStyle.Top;
                    item.SetArticle(article);

                    pnlNews.Controls.Add(item);
                }
            }
        }
        private void ShowFeedOnTreeView(List<Publisher> publishers)
        {
            tvwPublisher.Nodes.Clear();
            pnlNews.Controls.Clear();
            foreach(var publisher in publishers)
            {

                var publisherNode = tvwPublisher.Nodes.Add(publisher.Name);

                foreach(var category in publisher.Categories)
                {
                    publisherNode.Nodes.Add(category.Name);
                }
            }
            tvwPublisher.ExpandAll();
        }
    }
}
