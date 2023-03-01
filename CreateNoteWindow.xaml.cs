using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows;
using System.IO;
using System.Windows.Controls;

namespace WPFII
{
    /// <summary>
    /// Логика взаимодействия для CreateNoteWindow.xaml
    /// </summary>
    public partial class CreateNoteWindow : Window
    {
        public Note Note { get; set; }

        public CreateNoteWindow()
        {
            InitializeComponent();
            Note = new Note();
            DataContext = Note;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Note.Title = TitleTextBox.Text;
            Note.Content = ContentTextBox.Text;
            Note.CreatedAt = DateTime.Now;
            DialogResult = true;
        }

        private void Cancel_ButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
