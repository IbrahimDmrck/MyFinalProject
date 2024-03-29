﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist="Bu isimde bir ürün bulunmaktadır";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserAlreadyExists="Kullanıcı zaten mevcud";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string PasswordError="Yanlış şifre girişi";
        public static string UserNotFound="Böyle bir kullanıcı yok";
        public static string UserRegistered="Kayıt Olundu";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
