﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Model;

namespace Win.App.Server
{
    public class QuestionFactory
    {
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;



        private List<Quiz> _questions;

        public IEnumerable<Quiz> Questions
        {


            get
            {
                if (_questions == null)
                {
                    _questions = new List<Quiz>();

                    objConnect = new DatabaseConnection();
                    conString = Properties.Settings.Default.QuizBee1ConnectionString;

                    objConnect.connection_string = conString;
                    objConnect.Sql = Properties.Settings.Default.SQL;

                    ds = objConnect.GetConnection;
                    MaxRows = ds.Tables[0].Rows.Count;

                    string time;
                    ComboBox t = Application.OpenForms["Form1"].Controls["comboBox1"] as ComboBox;

                    //set the questions
                    for (int i = 0; i < MaxRows; i++)
                    {

                        dRow = ds.Tables[0].Rows[i];
                        time = t.Text;
                        

                        var quiz = new Quiz
                        {
                            Question = dRow.ItemArray.GetValue(0).ToString(),
                            Answer1 = new Choice() { Value = dRow.ItemArray.GetValue(2).ToString() },
                            Answer2 = new Choice() { Value = dRow.ItemArray.GetValue(3).ToString() },
                            Answer3 = new Choice() { Value = dRow.ItemArray.GetValue(4).ToString() },
                            Answer4 = new Choice() { Value = dRow.ItemArray.GetValue(5).ToString() },
                            Time = "" + time,
                            C_Answer = new Choice() { Value = dRow.ItemArray.GetValue(7).ToString() }
                        };
                        _questions.Add(quiz);
                    }

                }

                return _questions;
            }
        }




        private Random _randomizer;
        public Random Randomizer
        {
            get
            {
                if (_randomizer == null)
                {
                    _randomizer = new Random();
                }

                return _randomizer;
            }

        }

        public Quiz GetRandomItem()
        {
            var randomNumber = Randomizer.Next(1, 10);

            var quiz = Questions.Skip(randomNumber).Take(1).FirstOrDefault();
            return quiz;

        }

        public Quiz GetNextItem()
        {
             SetQuizIndex(Direction.Next);

            var result = Questions.ToList()[_currentQuizIndex];

          

            return result;
        }

        public Quiz GetPreviousItem()
        {
            SetQuizIndex(Direction.Previous);

            var result = Questions.ToList()[_currentQuizIndex];


            return result;
        }

        private int _currentQuizIndex = 0;
        private void SetQuizIndex(Direction direction)
        {
            //if the next quistion direction then increment the counter
            if (direction == Direction.Next)
                _currentQuizIndex++;

            //but if the direction is previous then decrement the counter
            else if (direction == Direction.Previous)
                _currentQuizIndex--;


            //this will make sure that the currentQuizIndex wont be negative values
            if (_currentQuizIndex < 0)
            {
                _currentQuizIndex = 0;
            }

            //this will make sure that the index wont be more than the total number of question
            var questionCount = Questions.Count();
            if (_currentQuizIndex >= questionCount)
            {
                _currentQuizIndex = questionCount - 1;
            }

        }

        private enum Direction
        {
            Next,
            Previous
        }


    }
}