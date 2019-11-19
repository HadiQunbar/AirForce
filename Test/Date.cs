using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Date
    {
        private int day;
        private int month;
        private int year;
        private int v1;
        private double v2;

        // טענת כניסה - מקבלת שלושה שדות מטיפוס שלם המציינים יום,חודש ושנה
        //טענת יציאה - מאתחלת עצם עם התכונות
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Date(int v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        // get nothing
        public Date() { }

        // using old methoed

        public Date DateFromOld()
        {
            Date NewDate;
            NewDate = new Date(14, 12, 1997);
            return NewDate;

        }

        // טענת כניסה - לא מקבלת פרמטרים
        //טענת יציאה - מאחזרת את התכונה יום
        public int getDay() { return day; }
        // טענת כניסה - מקבלת מספר המציין יום
        //טענת יציאה - מעדכנת את התכונה בהתאם לערך
        public void setDay(int day) { this.day = day; }
        // טענת כניסה - לא מקבלת פרמטרים
        //טענת יציאה - מאחזרת את התכונה חודש
        public int getMonth() { return month; }
        // טענת כניסה - מקבלת מספר המציין חודש
        //טענת יציאה - מעדכנת את התכונה בהתאם לערך
        public void setMonth(int month) { this.month = month; }
        // טענת כניסה - לא מקבלת פרמטרים
        //טענת יציאה - מאחזרת את התכונה שנה
        public int getYear() { return year; }
        // טענת כניסה - מקבלת מספר המציין שנה
        //טענת יציאה - מעדכנת את התכונה בהתאם לערך
        public void setYear(int year) { this.year = year; }
        // טענת כניסה - לא מקבלת פרמטרים
        //טענת יציאה - מחזירה מחרוזת הכוללת את תכונות העצם
        public String toString()
        {
            return day + "/" + month + "/" + year;
        }


    }
}

