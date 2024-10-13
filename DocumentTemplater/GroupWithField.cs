using System.Windows.Forms;

namespace DocumentTemplater
{
    public partial class GroupWithField : UserControl
    {
        public string NameBookmark
        {
            get
            {
                return groupBox.Text;
            }
        }
        public string ValueBookmark
        {
            get
            {
                return textBox.Text;
            }
        }
        public GroupWithField(string nameBookmark)
        {
            InitializeComponent();
            groupBox.Text = nameBookmark;
        }
    }
}
