using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WinFormsApp.EFModels;

namespace WinFormsApp.Presenter
{
    public class SamplePresenter : ISamplePresenter
    {
        private readonly WinFormsAppContext _context;
        private readonly SqlParameter _result;

        public SamplePresenter(WinFormsAppContext context)
        {
            _context = context;
            _result = new SqlParameter()
            {
                ParameterName = "Result",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output
            };
        }

        public List<EFModels.Color> GetColors()
        {
            try
            {
                return _context.Colors.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return [];
            }
        }

        public List<Models.User> GetUsers()
        {
            try
            {
                List<EFModels.Color> colors = GetColors();
                return _context.Users.Where(x => x.Deleted == false).AsEnumerable().Select(x => new Models.User
                {
                    Id = x.UserId,
                    Name = x.UserName,
                    Email = x.Email,
                    Birthday = x.BirthDay,
                    Color = colors.FirstOrDefault(y => y.ColorId == x.ColorId).ColorName,
                    Married = x.Married ? "Yes" : "No",
                    SubmitDate = x.SubmitDate,
                }).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return [];
            }
        }

        public void InsertUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                //_context.Database.ExecuteSqlRaw("InsertUser @UserId, @UserName, @Email, @BirthDay, @ColorId, @Married, @Result OUTPUT",
                //    new SqlParameter("@UserId", user.UserId),
                //    new SqlParameter("@UserName", user.UserName),
                //    new SqlParameter("@Email", user.Email),
                //    new SqlParameter("@BirthDay", user.BirthDay),
                //    new SqlParameter("@ColorId", user.ColorId),
                //    new SqlParameter("@Married", user.Married),
                //    _result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //return (int)_result.Value;
        }

        public void DeleteUser(long? userId)
        {
            try
            {
                var user = _context.Users.Find(userId);
                if (user != null)
                {
                    user.Deleted = true;
                    _context.SaveChanges();
                }
                //_context.Database.ExecuteSqlRaw("DeleteUser @UserId, @Result OUTPUT",
                //    new SqlParameter("@UserId", userId),
                //    _result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //return (int)_result.Value;
        }
    }
}
