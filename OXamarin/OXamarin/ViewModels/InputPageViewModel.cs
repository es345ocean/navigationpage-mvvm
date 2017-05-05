using OXamarin.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace OXamarin.ViewModels
{
    public class InputPageViewModel : BindableBase, INavigationAware
    {
        #region 定数

        public static readonly string InputKey = "InputKey";

        #endregion

        #region フィールド

        private string _title;
        private string _categoryID;

        #endregion

        #region プロパティ

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string CategoryID
        {
            get { return _categoryID; }
            set { SetProperty(ref _categoryID, value); }
        }

        #endregion

        #region メソッド

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //NavigationParameterに「InputKey」をキーとした
            //パラメーターを持っているかどうかの確認
            if (parameters.ContainsKey(InputKey))
            {
                var selectedItem = (TransitPage)parameters[InputKey];
                Title = selectedItem.CategoryName;
                CategoryID = selectedItem.CategoryID;
            }
        }

        #endregion
    }
}