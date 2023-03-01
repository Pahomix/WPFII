using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WPFII
{

    public partial class MainWindow : Window
    {
        private List<Note> notes = new List<Note>();

        public MainWindow()
        {
            InitializeComponent();
            LoadNotesFromFile();
            NotesListBox.ItemsSource = notes;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createNoteWindow = new CreateNoteWindow();
            createNoteWindow.ShowDialog();

            if (createNoteWindow.DialogResult.HasValue && createNoteWindow.DialogResult.Value)
            {
                var newNote = createNoteWindow.Note;
                notes.Add(newNote);
                SaveNotesToFile();
                NotesListBox.ItemsSource = null;
                NotesListBox.ItemsSource = notes;
            }
        }

        private void SaveNotesToFile()
        {
            var json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(@"C:\Users\Даниил Селезнев\Desktop\WPFII\notes.json", json);
        }

        private void LoadNotesFromFile()
        {
            if (File.Exists(@"C:\Users\Даниил Селезнев\Desktop\WPFII\notes.json"))
            {
                var json = File.ReadAllText(@"C:\Users\Даниил Селезнев\Desktop\WPFII\notes.json");
                notes = JsonConvert.DeserializeObject<List<Note>>(json);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Note selectedNote = NotesListBox.SelectedItem as Note;
            notes.Remove(selectedNote);
            SaveNotesToFile();
            UpdateNotesList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Note selectedNote = (Note)NotesListBox.SelectedItem;
            EditNoteWindow editNoteWindow = new EditNoteWindow(selectedNote);

            if (editNoteWindow.ShowDialog() == true)
            {
                Note editedNote = editNoteWindow.Note;
                int index = notes.IndexOf(selectedNote);
                notes[index] = editedNote;
                SaveNotesToFile();
                NotesListBox.ItemsSource = null;
                NotesListBox.ItemsSource = notes;
            }
        }

        private void UpdateNotesList()
        {
            notes.Clear();
            LoadNotesFromFile();
            NotesListBox.ItemsSource = notes;
        }

        private void notesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }
    }

}
