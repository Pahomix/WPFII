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

namespace WPFII
{
    /// <summary>
    /// Логика взаимодействия для EditNoteWindow.xaml
    /// </summary>
    public partial class EditNoteWindow : Window
    {
        public Note Note { get; private set; }

        public EditNoteWindow(Note note)
        {
            InitializeComponent();
            Note = new Note
            {
                Title = note.Title,
                Content = note.Content,
                CreatedAt = note.CreatedAt
            };

            TitleTextBox.Text = Note.Title;
            ContentTextBox.Text = Note.Content;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Note.Title = TitleTextBox.Text;
            Note.Content = ContentTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        public Note GetUpdatedNote()
        {
            Note note = new Note
            {
                Title = TitleTextBox.Text,
                Content = ContentTextBox.Text,
                CreatedAt = DateTime.Now
            };

            return note;
        }

    }
}
