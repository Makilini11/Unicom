﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Data
{
    internal static class Migration
    {
        public static void CreateTables()
        {
            using (var getDbconn = DatabaseManager.GetConnection())
            {



                string createTables =

                    @"CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                        );
                    

                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                        );
                    

                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                        );
                    

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                        );
                    

                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectID INTEGER,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                        );
                    

                    CREATE TABLE IF NOT EXISTS Marks (
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER,
                        ExamID INTEGER,
                        Score INTEGER,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                        );
                    

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL                        
                        );
                    

                    CREATE TABLE IF NOT EXISTS Timetables (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                        );
                ";

                SQLiteCommand Command = new SQLiteCommand(createTables, getDbconn);
                Command.ExecuteNonQuery();
            }
        

            /*foreach (var commandText in tableCommands)
            {
                using (var cmd = new SQLiteCommand(commandText, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            string insertAdminQuery = @"
                INSERT INTO Users (Username, Password, Role)
                SELECT 'admin1', 'pass123', 'Admin'
                WHERE NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'admin1');
                ";
            string insertStaffQuery = @"
                INSERT INTO Users(Username, Password, Role)
                SELECT 'staff1', 'pass456', 'Staff'
                WHERE NOT EXISTS(SELECT 1 FROM Users WHERE Username = 'staff1');
                 ";

            using (var cmd = new SQLiteCommand(insertAdminQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("Database tables created or already exist.");*/
        }
    }
}