using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopApp_3935
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection <Student> students;

        [ObservableProperty]
        public Student selectedStudent ;


        public MainWindowVM() {
            students = new ObservableCollection<Student>();

            students.Add(new Student("Marc", "Marques", 22, "8.png" ,3.78,"2000"));
            students.Add(new Student("Tony", "Stark", 22, "1.png", 3.78, "2000"));
            students.Add(new Student("Bruce", "Wayne", 22, "2.png", 3.78, "2000"));
        }

        [RelayCommand]
        public void AddStudent() {

            var New = new Add_StudentVM();
            Add_Student window_add = new Add_Student(New);
            window_add.ShowDialog();
            if (New.Newstudent.FirstName != null) {
                students.Add(New.Newstudent);
            }
        }



        [RelayCommand]
        public void EditStudent() {
            if (selectedStudent != null) {
                var existingStudent = new Add_StudentVM(selectedStudent);
                var window3 = new Add_Student(existingStudent);
                window3.ShowDialog();
                int index = students.IndexOf(selectedStudent);
                students.RemoveAt(index);
                students.Insert(index, existingStudent.Newstudent);
            }

            else {
                MessageBox.Show("Please select the student");
                
            }
        }

        [RelayCommand]
        public void DeleteStudent()
        {
            if (selectedStudent != null) {
                int index = students.IndexOf(selectedStudent);
                students.RemoveAt(index);

            }

            else {
                MessageBox.Show("Select a student");
            }
        }

        [RelayCommand]
        public void Exit()
        {
             Application.Current.Shutdown();
        }





    }
}
