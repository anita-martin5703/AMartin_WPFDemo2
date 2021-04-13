using System.Windows;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for SchoolWindow.xaml
    /// </summary>
    public partial class SchoolWindow : Window
    {
        School school;
        public SchoolWindow()
        {
            InitializeComponent();
            school = new School();
            lbCampuses.ItemsSource = school.Campus;
            lbCourses.ItemsSource = school.Course;
            lbMajor.ItemsSource = school.Major;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            StudentWindow studentWindow = new StudentWindow(newStudent);

            //StudentWindow studentWindow = new StudentWindow();
            //Student newStudent = studentWindow.Student;
            studentWindow.ShowDialog();
            if (studentWindow.DialogResult == true)
            {
                lbStudents.Items.Add(newStudent);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblCampus.Content = lbCampuses.SelectedItem.ToString()
                ;
        }
    }
}
