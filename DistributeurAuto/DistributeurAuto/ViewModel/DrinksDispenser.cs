using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;


namespace DistributeurAuto
{
    internal class DrinksDispenser : INotifyPropertyChanged
    {
        private IRecipe selectedRecipe;

        public IRecipe SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                selectedRecipe = value;
                NotifyPropertyChanged();
            }
        }

        private IEnumerable<IRecipe> recipes;
        public IEnumerable<IRecipe> Recipes 
        { 
            get => recipes; 
            set
            {
                recipes = value;
                NotifyPropertyChanged();
            }
        }

        public DrinksDispenser()
        {
            Recipes = Dao.LoadData();
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged
    }
}