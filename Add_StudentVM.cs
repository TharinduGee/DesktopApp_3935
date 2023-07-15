using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopApp_3935
{
    public partial class Add_StudentVM : ObservableObject {

        public Student Newstudent { get; private set; }

        public Action Close { get; set; }

        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public string doB;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public double gPAValue;
        [ObservableProperty]
        public string image;

        public Add_StudentVM() {

        }

        public Add_StudentVM(Student new_student) {
          
            firstName = new_student.FirstName;
            lastName = new_student.LastName;
            doB = new_student.DoB;
            age = new_student.Age;
            gPAValue = new_student.GPAValue;
            image = new_student.Image;

        }


        [RelayCommand]
        public void Add() {
            
            if (Newstudent == null) {
                Newstudent = new Student() {
                    FirstName = firstName,
                    LastName = lastName,
                    DoB = doB,
                    Age = age,
                    GPAValue = gPAValue,
                    Image = image
                };
            }
            else {
                Newstudent.FirstName = firstName;
                Newstudent.LastName = lastName;
                Newstudent.DoB = doB;
                Newstudent.Age = age;
                Newstudent.GPAValue = gPAValue;
                Newstudent.Image = image;
            }


            if (Newstudent.FirstName != null) {
                Close();
                
            }

          
          
        }


    }
}
