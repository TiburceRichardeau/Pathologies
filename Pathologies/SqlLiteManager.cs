﻿using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pathologies
{
    public class SqlLiteManager
    {
        private string _strConn = "Data Source=database.db;Version=3;";
        private SQLiteConnection _con;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public SqlLiteManager()
        {
            _con = new SQLiteConnection(_strConn);
        }

        public List<Pathologie> GetAllPathologies()
        {
            try
            {
                _con.Open();

                List<Pathologie> list = new List<Pathologie>();

                string sql = "SELECT * FROM pathologie";
                SQLiteCommand command = new SQLiteCommand(sql, _con);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    list.Add(new Pathologie(reader["id"].ToString(),reader["nom"].ToString(),reader["causes"].ToString(), reader["symptomes"].ToString(), reader["approche_alimentaire"].ToString(), reader["complements_alimentaires"].ToString(), reader["autre_approche"].ToString()));

                _con.Close();

                return list;

            }
            catch (Exception e)
            {
                logger.Error(e);
                return null;
            }            
        }

        public bool AjouterPathologie(Pathologie path)
        {
            try
            {
                _con.Open();

                SQLiteCommand command = new SQLiteCommand(_con);
                //Requete param car pb avec les , et '
                command.CommandText = @"INSERT INTO pathologie(nom,causes,symptomes,approche_alimentaire,complements_alimentaires,autre_approche) VALUES (@nom, @causes, @symptomes, @approche_alimentaire, @complements_alimentaires, @autre_approche)";
                SQLiteParameter nom = new SQLiteParameter("@nom", path.nom);
                SQLiteParameter causes = new SQLiteParameter("@causes", path.causes);
                SQLiteParameter symptomes = new SQLiteParameter("@symptomes", path.symptomes);
                SQLiteParameter approche_alimentaire = new SQLiteParameter("@approche_alimentaire", path.approche_alimentaire);
                SQLiteParameter complements_alimentaires = new SQLiteParameter("@complements_alimentaires", path.complements_alimentaires);
                SQLiteParameter autre_approche = new SQLiteParameter("@autre_approche", path.autre_approche);


                command.Parameters.Add(nom);
                command.Parameters.Add(causes);
                command.Parameters.Add(symptomes);
                command.Parameters.Add(approche_alimentaire);
                command.Parameters.Add(complements_alimentaires);
                command.Parameters.Add(autre_approche);

                command.ExecuteNonQuery();

                _con.Close();

                return true;

            }
            catch (Exception e)
            {
                logger.Error(e);
                return false;
            }
        }

        internal void ModifierPathologie(Pathologie pathologie)
        {
            try
            {
                _con.Open();

                SQLiteCommand command = new SQLiteCommand(_con);
                command.CommandText = "UPDATE pathologie SET nom = @nom, causes = @causes, symptomes = @symptomes, approche_alimentaire = @approche_alimentaire, complements_alimentaires = @complements_alimentaires, autre_approche = @autre_approche WHERE id = " + pathologie.id + "; ";
                SQLiteParameter nom = new SQLiteParameter("@nom", pathologie.nom);
                SQLiteParameter causes = new SQLiteParameter("@causes", pathologie.causes);
                SQLiteParameter symptomes = new SQLiteParameter("@symptomes", pathologie.symptomes);
                SQLiteParameter approche_alimentaire = new SQLiteParameter("@approche_alimentaire", pathologie.approche_alimentaire);
                SQLiteParameter complements_alimentaires = new SQLiteParameter("@complements_alimentaires", pathologie.complements_alimentaires);
                SQLiteParameter autre_approche = new SQLiteParameter("@autre_approche", pathologie.autre_approche);


                command.Parameters.Add(nom);
                command.Parameters.Add(causes);
                command.Parameters.Add(symptomes);
                command.Parameters.Add(approche_alimentaire);
                command.Parameters.Add(complements_alimentaires);
                command.Parameters.Add(autre_approche);

                command.ExecuteNonQuery();

                _con.Close();

            }
            catch (Exception e)
            {
                logger.Error(e);
            }
        }

        internal void DeletePathologie(Pathologie path)
        {
            try
            {
                _con = new SQLiteConnection(_strConn);
                _con.Open();

                string sql = "DELETE FROM pathologie WHERE id =" + path.id; ;
                SQLiteCommand command = new SQLiteCommand(sql, _con);

                command.ExecuteScalar();

                _con.Close();

            }
            catch (Exception e)
            {
                logger.Error(e);
            }
        }

        public int GetNbPathologies()
        {
            try
            {
                _con.Open();

                string sql = "SELECT COUNT(*) FROM pathologie;";
                SQLiteCommand command = new SQLiteCommand(sql, _con);

                object result = command.ExecuteScalar();
                return Convert.ToInt32(result);

            }
            catch (Exception e)
            {
                logger.Error(e);
                return -1;
            }
        }
    }
}
