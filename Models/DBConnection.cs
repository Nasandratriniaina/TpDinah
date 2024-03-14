using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AppDotNet.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionString =
    new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TodoDBConnection"].ConnectionString);

        public static void AjoutUser(Utilisateur utilisateur)
        {
                var req = $"INSERT INTO public.\"utilisateur\"(nom, prenom, cin)"+
                    $" VALUES ('{utilisateur.name}', '{utilisateur.lastname}', '{utilisateur.cin}');";

                try
                {
                connectionString.Open();
                    var cmd = new NpgsqlCommand(req, connectionString);
                    cmd.ExecuteNonQuery();
                connectionString.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }

