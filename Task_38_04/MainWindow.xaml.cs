using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class _class = new();
        public MainWindow()
        {
            InitializeComponent();
            sexComboBox.SelectedIndex = 1;
            studentsListBox.ItemsSource = _class.Students;
        }

        #region обработчики_Событий_WPF_элементов
        private void addStudentButton_Click(object sender, RoutedEventArgs e) //----------------------КНОПКА ДОБАВИТЬ
        {
            if (!Validate(out string errorMessage)) //если данные не прошли валидацию
            {
                MessageBox.Show(errorMessage); //то показываем сообщение об ошибке(ах)
                return; //завершаем метод
            }

            //если валидация пройдена, то собираем объект книги
            Student student = new Student(
                nameTextBox.Text, //название из поля titleTextBox
                surnameTextBox.Text, //название из поля titleTextBox
                lastnameTextBox.Text, //название из поля titleTextBox
                Int32.Parse(groupTextBox.Text), // год издания из поля yearTextBox с преобразование в int
                (Sex)sexComboBox.SelectedIndex //состояние - из выпадающего списка берется индекс выбранного элемента
                );

            _class.AddStudent(student); //вызывается метод добавления книги в библиотеку

            studentsListBox.Items.Refresh(); //обновление элементов ListBox чтобы отобразить все изменения
            Clear();
        }
        private void clearStudentButton_Click(object sender, RoutedEventArgs e) //--------------------КНОПКА ОЧИСТИТЬ
        {
            Clear();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) //----------------------------ЗАГРУЗКА ОКНА
        {
            _class.Load();
            studentsListBox.ItemsSource = _class.Students;
        }
        private void Window_Closed(object sender, EventArgs e)  //---------------------------------ЗАКРЫТИЕ ОКНА
        {
            _class.Save();
        }
        private void deleteStudentMenuItem_Click(object sender, RoutedEventArgs e) //-----------------КОНТЕКСТНОЕ МЕНЮ "УДАЛИТЬ"
        {
            //извлекаем выбранный элемент из ListBox
            var item = studentsListBox.SelectedItem;

            //проверяем его на пустоту и является ли он по факту книгой
            if (item != null && item is Student student)
            {
                _class.RemoveStudent(student); //вызываем удаление книги из библиотеки
                studentsListBox.Items.Refresh(); //обновляем ListBox
            }
        }
        private void showInfoMenuItem_Click(object sender, RoutedEventArgs e) //-------------------КОНТЕКСТНОЕ МЕНЮ "ПОДРОБНЕЕ"
        {
            ShowStudentInfo();
        }
        private void studentsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) //-------ДВОЙНОЙ КЛИК ПО ЭЛЕМЕНТУ СПИСКА
        {
            ShowStudentInfo();
        }
        #endregion

        #region вспомомагательные_методы
        //метод-валидатор вводимых данных
        private bool Validate(out string error) //-------------------------------------------------ВАЛИДАЦИЯ ВХОДНЫХ ДАННЫХ
        {
            error = "";
            try //есть вероятность что в поле года будет текст, который не преобразовать к числу
            {
                int year = Convert.ToInt32(groupTextBox.Text);
            }
            catch (FormatException ex)
            {
                error = "группа - не число\n";
            }

            if (string.IsNullOrEmpty(nameTextBox.Text))  //проверка названия на пустые данные
            {
                error += "Имя пусто\n";
            }
            if (string.IsNullOrEmpty(surnameTextBox.Text)) //проверка автора на пустые данные
            {
                error += "Фамилия пусто\n";
            }
            if (string.IsNullOrEmpty(lastnameTextBox.Text)) //проверка автора на пустые данные
            {
                error += "отчество пусто\n";
            }

            if (error.Length > 0)
            {
                return false;
            }
            return true;
        }
        private void Clear()    //-----------------------------------------------------------------ОЧИСТКА ПОЛЕЙ ВВОДА
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            lastnameTextBox.Clear();
            groupTextBox.Clear();
            sexComboBox.SelectedIndex = 1;
        }
        private void ShowStudentInfo() //-------------------------------------------------------------ВСПЛЫВАЮЩЕЕ ОКНО С ИНФОРМАЦИЕЙ ПО ВЫБРАННОЙ КНИГЕ
        {
            var item = studentsListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                MessageBox.Show($"{student.Name}\n" +
                    $"{student.Surname}\n" +
                    $"группа: {student.Group}\n" +
                    $"пол - {student.Sex}");
            }
        }
        #endregion
    }
}