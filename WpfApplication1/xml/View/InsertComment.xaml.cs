using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace xml.View
{
    /// <summary>
    /// Logika interakcji dla klasy InsertComment.xaml
    /// </summary>
    public partial class InsertComment : Window
    {
        public XElement comment;
        public InsertComment(XElement CommentUri)
        {
            InitializeComponent();
            this.comment = CommentUri;
            Comment.Text = CommentUri.Value;
        }

        private void Comment_TextChanged(object sender, TextChangedEventArgs e)
        {
            comment.Value = Comment.Text;
        }

    }
}
