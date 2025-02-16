﻿using LW11.Classes;
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

namespace LW11
{
    /// <summary>
    /// Логика взаимодействия для AddStudentWnd.xaml
    /// </summary>
    public partial class AddStudentWnd : Window
    {
        public AddStudentWnd()
        {
            InitializeComponent();
            BirthdayBox.DisplayDateEnd = DateTime.Now;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            try
            {
                student.Name = NameBox.Text;
                student.Surname = SurnameBox.Text;
                student.Patronymic = PatronymicBox.Text;
                student.Speciality = SpecialityBox.Text;
                student.Birthday = Convert.ToDateTime(BirthdayBox.Text);
                student.Course = Convert.ToInt32(CourseBox.Text);
                student.GroupNumber = Convert.ToInt32(GroupBox.Text);
                if (GenderBox.Text == "Male")
                {
                    student.Gender = "Male";
                }
                else if (GenderBox.Text == "Female")
                {
                    student.Gender = "Female";
                }
                student.PhoneNumber = PhoneBox.Text;
                student.ImageSrc = ImageBox.Text;

                MessageBox.Show("Student added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (UniversityModel db = new UniversityModel())
            {
                try
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }
    }
}
