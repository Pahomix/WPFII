using System;
using Newtonsoft.Json;
using System.Windows;
using System.IO;

namespace WPFII
{
    /// <summary>
    /// Логика взаимодействия для CreateNoteWindow.xaml
    /// </summary>
    public partial class CreateNoteWindow : Window
    {
        private readonly string filePath = "C:\\Users\\Даниил Селезнев\\Desktop\\WPFII\\notes.json";

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новую заметку
            Note newNote = new Note
            {
                Title = TitleTextBox.Text,
                Content = ContentTextBox.Text,
                IsDone = false,
                CreatedAt = DateTime.Now
            };

            // Получаем все заметки из файла
            string notesJson = File.ReadAllText(filePath);
            Note[] notes = JsonConvert.DeserializeObject<Note[]>(notesJson) ?? new Note[] { };

            // Добавляем новую заметку к остальным
            Array.Resize(ref notes, notes.Length + 1);
            notes[1] = newNote;

            // Сохраняем все заметки в файл
            string newNotesJson = JsonConvert.SerializeObject(notes, Formatting.Indented);
            File.WriteAllText(filePath, newNotesJson);

            // Закрываем окно
            Close();
        }

        private void Cancel_ButtonClick(object sender, RoutedEventArgs e)
        {
            // Закрываем окно
            Close();
        }
    }
    }
}
