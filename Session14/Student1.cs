﻿namespace Session14
{
    internal class Student
    {
        private string v1;
        private int v2;

        public Student(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int StudentID { get; internal set; }
        public string Program { get; internal set; }
    }
}