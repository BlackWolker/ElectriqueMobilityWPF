using ElectriqueMobility.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectriqueMobility.ViewModel
{
    internal class ViewModelCategorie : INotifyPropertyChanged
    {
        electricmobilityEntities db;

        public event PropertyChangedEventHandler PropertyChanged;

        private List<categorie> lesCategories;
        private categorie uneCategorie;


        public ViewModelCategorie()
        {
            db = new electricmobilityEntities();
            lesCategories = getLesCategories();
            uneCategorie = null;
        }

        //pour le rafraichissement
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<categorie> LesCategories
        {
            get => lesCategories;
            set { if (lesCategories != value) { lesCategories = value; OnPropertyChanged(); } }
        }

        public categorie UneCategorie
        {
            get => uneCategorie;
            set { if (uneCategorie != value) { uneCategorie = value; OnPropertyChanged(); } }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<categorie> getLesCategories()
        {
            try
            {
                lesCategories = db.categorie.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur getLesCategories : " + ex.Message);
            }
            return lesCategories;
        }




        /// <summary>
        /// Retourne une Categorie précise
        /// </summary>
        /// <param name="leNumero"></param>
        /// <returns>Categorie</returns>
        public categorie getUneCategorie(int identifiant)
        {
            try
            {
                uneCategorie = db.categorie.FirstOrDefault(c => c.id == identifiant);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur uneCategorie : " + ex.Message);
            }
            return uneCategorie;
        }




        /// <summary>
        /// Permet d'ajouter la Categorie passée en paramètre dans la table Categorie de la base de données
        /// </summary>
        /// <param name="uneCategorie">Objet Categorie instancié</param>
        public void insertCategorie(categorie uneCategorie)
        {
            try
            {
                db.categorie.Add(uneCategorie);
                db.SaveChanges();
                lesCategories.Add(uneCategorie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur insertCategorie : " + ex.Message);
            }

        }
        /// <summary>
        /// /// Permet de modifier la catégorie passée en paramètre dans la table Categorie de la base de données
        /// </summary>
        /// <param name="uneCategorie">La catégorie à modifier</param>
        public void updateCategorie(categorie uneCategorie)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur updateCategorie : " + ex.Message);
            }


            // Mise à jour de la liste
            // lesCategorie = getLesCategorie();


        }

        /// <summary>
        /// Permet de supprimer la catégorie passée en paramètre dans la table Categorie de la base de données
        /// </summary>
        /// <param name="Code">Code de la Categorie : chaine de caractères</param>
        public void deleteCategorie(categorie uneCategorie)
        {
            try
            {
                db.categorie.Remove(uneCategorie);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur deleteCategorie: " + ex.Message);
            }



        }
    }
}
