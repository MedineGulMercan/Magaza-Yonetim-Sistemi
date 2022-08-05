using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Core.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        SqlConnection sql;
        private string proc, tablename, sqlCon = "Data Source=DESKTOP00111\\SQLEXPRESS;Initial Catalog=Magaza;Integrated Security=true;";

        public GenericRepository(string _tablename)
        {
            if(sql == null)
            
                sql = new SqlConnection(sqlCon);
                tablename = _tablename;
        }



        public async Task? CreateAsync(T? entity)
        {
            using (sql = new SqlConnection(sqlCon))
            {
                try
                {
                    sql.Open();
                    proc = $"sp_{tablename}Ekle";
                    await sql.ExecuteAsync(proc, entity, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw new($"{tablename} tablosuna kayıt eklenmedi");
                }
                finally
                {
                    sql.Close();
                }
            }
               
        }

        public async Task DeleteAsync(int? id)
        {
            using (sql = new SqlConnection(sqlCon))
            {
                try
                {
                    sql.Open();
                    await sql.ExecuteAsync($"Update {tablename}  set Aktifmi=0 where Id=@Id", new { Id = id });

                }
                catch (Exception)
                {

                    throw new($"{tablename} tablosuna kayıt silinmedi");
                }
                finally { sql.Close(); }
            }
        }

        public async Task<IEnumerable<T>>? GetAllAsync()
        {
            using (sql = new SqlConnection(sqlCon))
            {
                try
                {
                    sql.Open();
                    return await sql.QueryAsync<T>($"select * from [{tablename}]");


                }
                catch (Exception)
                {

                    throw new($"{tablename} tablonun içinde veri yok"); ;
                }
                finally
                {
                    sql.Close();
                }
            }
        }

        public async Task<T>? GetAsync(int? id)
        {
            using (sql = new SqlConnection(sqlCon))
            {
                try
                {
                    sql.Open();
                    return await sql.QuerySingleOrDefaultAsync<T>($"select * from {tablename} where Id=@Id", new { Id = id });

                }
                catch (Exception)
                {

                    throw new($"{tablename} tablonun içinde veri yok ");
                }
                finally
                {
                    sql.Close();
                }
            }
        }

        public async Task UpdateAsync(T? entity)
        {
            using (sql = new SqlConnection(sqlCon))
            {
                try
                {
                    sql.Open();
                    proc = $"sp_{tablename}Guncelle";
                    await sql.ExecuteAsync(proc, entity,commandType : CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw new($"{tablename} tablonun içinde veri yok ");
                }
                finally { sql.Close(); }
            }
        }
    }
}
