﻿using System.Collections.Generic;
using OXamarin.Models;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace OXamarin.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatedAware
    {
        #region フィールド

        private List<TransitPage> _largeCategories = new List<TransitPage>
        {
            new TransitPage
            {
                CategoryID = "EntertainmentAndHobby",
                CategoryName ="エンターテイメントと趣味",
            },
            new TransitPage
            {
                CategoryID = "LifeAndLivingGuide",
                CategoryName ="暮らしと生活ガイド",
            },
               new TransitPage
            {
                CategoryID = "HealthAndBeautyAndFashion",
                CategoryName ="健康、美容とファッション",
            },
            //"マナー、冠婚葬祭",
            //"生き方と恋愛、人間関係の悩み",
            //"子育てと学校",
            //"インターネット、通信",
            //"スマートデバイス、PC、家電",
            //"コンピュータテクノロジー",
            //"教養と学問、サイエンス",
            //"ビジネス、経済とお金",
            //"ニュース、政治、国際情勢",
            //"職業とキャリア",
            //"スポーツ、アウトドア、車",
            //"地域、旅行、お出かけ",
            //"その他",
        };
        private readonly INavigationService _navigationService;

        #endregion

        #region プロパティ

        public List<TransitPage> LargeCategories
        {
            get { return _largeCategories; }
            set { SetProperty(ref _largeCategories, value); }
        }

        #endregion

        #region コマンド
        
        public Command<TransitPage> LargeCategorySelectedCommand { get; set; }

        #endregion

        #region コンストラクタ

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LargeCategorySelectedCommand = new Command<TransitPage>(NavigateReportPage);
        }

        #endregion

        #region メソッド

        /// <summary>
        /// InputPageへの遷移
        /// </summary>
        private void NavigateReportPage(TransitPage selectedItem)
        {
            var navigationParameter = new NavigationParameters
            {
                { InputPageViewModel.InputKey, selectedItem }
            };
            _navigationService.NavigateAsync("InputPage", navigationParameter);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        #endregion
    }
}