﻿using System;
using System.Text;
using ConsoleTables;
using MyFirstProject.Infrastructure.Models;
using MyFirstProject.Infrastructure.Services;

namespace MyFirstProject
{
    class Program
    {
        private static readonly MarketableService _marketableService = new MarketableService();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int selectInt;
            do
            {
                #region First Menu
                Console.WriteLine("=========Market idare etmək sistemi========== ");
                Console.WriteLine("1. Məhsullar üzərində əməliyyat aparmaq ");
                Console.WriteLine("2. Satışlar üzərində əməliyyat aparmaq ");
                Console.WriteLine("0. sistemdən çıxmaq ");
                #endregion
                #region First Menu Selection 
                Console.WriteLine("seçiminiz edin: ");
                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #endregion

                #region Menu Swicth
                switch (selectInt)
                {
                    case 0:
                        continue;
                   case 1:
                        ShowProductsMenu();
                        break;
                    case 2:
                        ShowSale();
                        break;
                    
                    default:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("==========Siz yanlış seçim etdiniz 0-2 arası seçim edə bilərsiz =========== ");
                        Console.WriteLine("----------------------------------");
                        break;
                }
               
                #endregion
                

            } while (selectInt != 0);
           // product isdediklerini gosdermey ucun 
            static void ShowProductsMenu()
            
                     #region second Menu 
            {
                    int SelectInt1;
                    do
                    {
                    Console.WriteLine("---------------Məhsullar üzərində əməliyyat aparmaq--------------");
                    Console.WriteLine("1. Yeni məhsul əlavə et ");
                    Console.WriteLine("2. Məhsul üzərində düzəliş et ");
                    Console.WriteLine("3. Məhsulu sil");
                    Console.WriteLine("4. Bütün məhsulları göstər ");
                    Console.WriteLine("5. Kateqoriyasına görə məhsulları göstər");
                    Console.WriteLine("6. Qiymət aralığına görə məhsulları göstər ");
                    Console.WriteLine("7. Məhsullar arasında ada görə axtarış et ");
                    #endregion

                    #region Second Menu Selections

                    string Select = Console.ReadLine();
                    while (!int.TryParse(Select, out SelectInt1))
                    {
                    Console.WriteLine("Rəqəm daxil etməlisiniz");
                    Select = Console.ReadLine();
                     }


                    #endregion

                    #region second Menu Switch
                    switch (SelectInt1)
                    {
                        case 1:
                            continue;
                        case 2:
                            continue;
                        case 3:
                            continue;
                        case 4:
                            continue;
                        case 5:
                            continue;
                        case 6:
                            continue;
                        case 7:
                            continue;                         
                        default:
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("siz yalnış seçim etdiniz,1-7 arasında seçim edin ");
                            Console.WriteLine("----------------------------------------------------");
                            break;
                    }



                    #endregion


                } while (SelectInt1 != 0);

            }
             
           //satis isdeklerni gosdermek ucun 
            static void  ShowSale()
            #region Three  Menu 
            {
                int SelectInt2;
                do
                {

                    Console.WriteLine("--------------Satışlar üzərində əməliyyat aparmaq----------------");
                    Console.WriteLine("1. Yeni satış əlavə etmək ");
                    Console.WriteLine("2. Satışdan hansısa məhsulun geri qaytarılması");
                    Console.WriteLine("3. Satışın silinməsi ");
                    Console.WriteLine("4. Bütün satışların ekrana çıxarılması");
                    Console.WriteLine("5. Verilən tarix aralığına görə satışların göstərilməsi ");
                    Console.WriteLine("6. Verilən məbləğ aralığına görə satışların göstərilməsi ");
                    Console.WriteLine("7. Verilmiş bir tarixdə olan satışların göstərilməsi");
                    Console.WriteLine("8. Verilmiş nömrəyə əsasən həmin nömrəli satışın məlumatlarının göstərilməsi ");
                    #endregion
                    #region Three Menu Selections
                    string Select = Console.ReadLine();
                    while (!int.TryParse(Select, out SelectInt2))
                    {
                        Console.WriteLine("Rəqəm daxil etməlisiniz");
                        Select = Console.ReadLine();
                    }

                    #endregion
                    #region Three Menu Switch
                    switch (SelectInt2)
                    {
                        case 1:
                            continue;
                        case 2:
                            continue;
                        case 3:
                            continue;
                        case 4:
                            continue;
                        case 5:
                            continue;
                        case 6:
                            continue;
                        case 7:
                            continue;
                        case 8:
                            continue;
                        default:
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("siz yalnış seçim etdiniz,1-8 arasında seçim edin ");
                            Console.WriteLine("----------------------------------------------------");
                            break;
                    }


                    #endregion


                } while (SelectInt2 != 0);

               

               
            }
            #region Show Methods 
            static void ShowProductList()
            {
                Console.WriteLine("-------------- Mövcud satışlar --------------");

                var table = new ConsoleTable("No", "Kateqoriya", "Məhsul", "Sayı", "Qiyməti", "Toplam");
                int i = 1;
                foreach (var item in _marketableService.Products)
                {
                    table.AddRow(i, item.ProductCatagory, item.ProductName, item.ProductQuantity, item.ProductPrice, (item.ProductPrice * item.ProductPrice).ToString("#.##"));
                    i++;
                }

                table.Write();
            }
            #endregion
            // Add product methodu yaradag 
            static void ShowAddProduct()
            {
                Console.WriteLine("------------------Yeni satış əlavə et-------------------");
                Product product = new Product();

                #region ProductCategoryType 
                Console.WriteLine("kateqori daxil edin :");
                product.ProductCatagory = Console.ReadLine();
                #endregion

                #region ProductName
                Console.WriteLine("Məhsulun adını daxil edin :");
                product.ProductName = Console.ReadLine();
                #endregion

                #region ProductPrice 
                Console.WriteLine("Satışın qiymətini daxil edin :");
                product.ProductPrice = Console.ReadLine();
                double Price;
                while (!int.TryParse(ProductPriceInput,out Price))
                {
                    Console.WriteLine("Ancaq rəqəm daxil etməlisiniz :");
                    ProductPriceInput = Console.ReadLine();
                }
                product.Price = Price;
                #endregion

                #region ProductQuantity 
                Console.WriteLine("Satış sayını daxil edin :");
                product.ProductQuantity = Console.ReadLine();
                int ProductQuantity;
                while (!int.TryParse(quantityInput, out quantity))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    quantityInput = Console.ReadLine();
                }
                product.ProductQuantity;
                #endregion

                #region ProductCode
                Console.WriteLine("Produqtun nömrəsini daxil edin :");
                product.ProductCode = Console.ReadLine();

                #endregion
                _marketableService.AddProduct(product);

                Console.WriteLine("-------------- Yeni satış əlavə edildi --------------");
            }
            
           

        }
    }
}
