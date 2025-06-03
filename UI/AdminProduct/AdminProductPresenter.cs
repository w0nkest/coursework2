using Classes;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class AdminProductPresenter : IAdminProductPresenter
    {
        private IAdminProduct view;
        private List<Goods> goods;

        public AdminProductPresenter(IAdminProduct frm, List<Goods> goods)
        {
            this.goods = goods;
            view = frm;

            foreach (var good in goods)
            {
                view.productListAdd(good);
            }
        }

        public void setProductData(Goods good)
        {
            view.setName(good.Name);
            view.setPrice(good.Price.ToString());
        }

        public void updateProduct(Goods good, string newname, string newprice)
        {
            if (good is null)
            {
                view.raiseMsgBox("Товар не был выбран!");
                return;
            }
            if (newname.Length == 0 || newprice.Length == 0)
            {
                view.raiseMsgBox("Какое-то значение не было введено!");
                return;
            }
            if (Convert.ToInt32(newprice) <= 0)
            {
                view.raiseMsgBox("Цена не может быть установлена 0 или меньше!");
                return;
            }

            Goods newgood;

            if (typeof(TimeGoods) == good.GetType())
            { 
                newgood = new TimeGoods(newname, Convert.ToInt32(newprice));
            }

            else
            {
                newgood = new SingleGoods(newname, Convert.ToInt32(newprice));
            }

            newgood.ID = good.ID;

            goods[goods.IndexOf(good)] = newgood;

            view.productListUpdate(good, newgood);

            productUpdating(newgood);

            view.setInfoText($"Продукт {good} был изменен! Теперь он - {newgood}");
        }

        public void createProduct(string newname, string newprice, bool isTime)
        {
            if (newname.Length == 0 || newprice.Length == 0)
            {
                view.raiseMsgBox("Какое-то значение не было введено!");
                return;
            }

            if (Convert.ToInt32(newprice) <= 0)
            {
                view.raiseMsgBox("Цена не может быть установлена 0 или меньше!");
                return;
            }

            Goods good;

            if (isTime)
            {
                good = new TimeGoods(newname, Convert.ToInt32(newprice));
            }
            else
            {
                good = new SingleGoods(newname, Convert.ToInt32(newprice));
            }

            view.productListAdd(good);
            goods.Add(good);

            newProductAdding(good);

            view.setInfoText($"Продукт {good} был создан!");
        }

        public void removeProduct(Goods good)
        {
            if (good is null)
            {
                view.raiseMsgBox("Объект для удаления не выбран!");
                return;
            }
            view.productListRemove(good);
            goods.Remove(good);

            productDeleting(good);

            view.setInfoText($"Продукт {good} был удален!");
        }

        private void newProductAdding(Goods good)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            if (typeof(TimeGoods) == good.GetType())
                            {
                                command.CommandText = "INSERT INTO time_products (product, price_per_hour)" +
                                    $"VALUES ('{good.Name}', {good.GetPrice()})";
                            }
                            else
                            {
                                command.CommandText = "INSERT INTO single_products (product, price)" +
                                    $"VALUES ('{good.Name}', {good.GetPrice()})";
                            }
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void productDeleting(Goods good)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            if (typeof(TimeGoods) == good.GetType())
                            {
                                command.CommandText = $"DELETE FROM time_products WHERE ID = {good.ID}";
                            }
                            else command.CommandText = $"DELETE FROM single_products WHERE ID = {good.ID}";

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void productUpdating(Goods good)
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            if (typeof(TimeGoods) == good.GetType())
                            { 
                                command.CommandText = $"UPDATE time_products SET product = '{good.Name}', price_per_hour = {good.Price} WHERE ID = {good.ID}";
                            }
                            else command.CommandText = $"UPDATE single_products SET product = '{good.Name}', price = {good.GetPrice()} WHERE ID = {good.ID}";

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
