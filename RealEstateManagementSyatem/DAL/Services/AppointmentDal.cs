using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AppointmentDAL : SharedDAL, IAppointmentContract
    {
        #region DataTypes, Constructor
        public AppointmentDAL()
        {

        }
        #endregion

        #region Shared

        public bool AddNewAppointment(AppointmentDE mod)
        {
            bool retVal = true;

            SqlConnection con = new SqlConnection(_conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ManageAppointment";
            if(mod.Id == 0)
            {
                cmd.Parameters.AddWithValue("@Query", 1);
                cmd.Parameters.AddWithValue("@AppointmentId", -1);
                cmd.Parameters.Add("@PostCode", SqlDbType.VarChar, 10).Value = mod.PostCode;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = mod.Address;
                cmd.Parameters.Add("@NoOfBedrooms", SqlDbType.VarChar, 100).Value = mod.NoOfBedrooms;
                cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int).Value = mod.PropertyTypeId;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 200).Value = mod.FirstName;
                cmd.Parameters.Add("@SurName", SqlDbType.VarChar, 200).Value = mod.SurName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = mod.Email;
                cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = mod.MobileNo;
                cmd.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Connection = con;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Query", 2);
                cmd.Parameters.Add("@AppointmentId", SqlDbType.Int).Value = mod.Id;
                cmd.Parameters.Add("@PostCode", SqlDbType.VarChar, 10).Value = mod.PostCode;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = mod.Address;
                cmd.Parameters.Add("@NoOfBedrooms", SqlDbType.VarChar, 100).Value = mod.NoOfBedrooms;
                cmd.Parameters.Add("@PropertyTypeId", SqlDbType.Int).Value = mod.PropertyTypeId;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 200).Value = mod.FirstName;
                cmd.Parameters.Add("@SurName", SqlDbType.VarChar, 200).Value = mod.SurName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = mod.Email;
                cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = mod.MobileNo;
                cmd.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Connection = con;
            }

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retVal = false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return retVal;
        }
        public List<AppointmentDE> GetAllAppointments()
        {
            List<AppointmentDE> list = new List<AppointmentDE>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _conStr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ManageAppointment";
                cmd.Parameters.AddWithValue("@Query", 5);
                cmd.Parameters.AddWithValue("@AppointmentId", -1);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        AppointmentDE appointment = new AppointmentDE();
                        appointment.Id = rdr["Id"] != DBNull.Value ? (int)rdr["Id"] : -1;
                        appointment.AppointmentDate = rdr["AppointmentDate"] != DBNull.Value ? (DateTime)rdr["AppointmentDate"] : DateTime.Now;
                        appointment.FirstName = rdr["FirstName"] != DBNull.Value ? (string)rdr["FirstName"] : string.Empty;
                        appointment.SurName = rdr["SurName"] != DBNull.Value ? (string)rdr["SurName"] : string.Empty;
                        appointment.Email = rdr["Email"] != DBNull.Value ? (string)rdr["Email"] : string.Empty;
                        appointment.MobileNo = rdr["MobileNo"] != DBNull.Value ? (string)rdr["MobileNo"] : string.Empty;
                        appointment.PropertyType = rdr["PropertyType"] != DBNull.Value ? (string)rdr["PropertyType"] : string.Empty;
                        appointment.PostCode = rdr["PostCode"] != DBNull.Value ? (string)rdr["PostCode"] : string.Empty;
                        appointment.Address = rdr["Address"] != DBNull.Value ? (string)rdr["Address"] : string.Empty;
                        appointment.NoOfBedrooms = rdr["NoOfBedrooms"] != DBNull.Value ? (string)rdr["NoOfBedrooms"] : string.Empty;
                        appointment.PropertyTypeId = rdr["PropertyTypeId"] != DBNull.Value ? (int)rdr["PropertyTypeId"] : -1;

                        list.Add(appointment);
                    }
                }
            }
            catch (Exception ex)
            {
                list = null;
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public AppointmentDE GetAppointmentById(int id)
        {
            AppointmentDE mod = new AppointmentDE();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _conStr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ManageAppointment";
                cmd.Parameters.AddWithValue("@Query", 4);
                cmd.Parameters.AddWithValue("@AppointmentId", id);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        AppointmentDE appointment = new AppointmentDE();
                        appointment.Id = rdr["Id"] != DBNull.Value ? (int)rdr["Id"] : -1;
                        appointment.AppointmentDate = rdr["AppointmentDate"] != DBNull.Value ? (DateTime)rdr["AppointmentDate"] : DateTime.Now;
                        appointment.FirstName = rdr["FirstName"] != DBNull.Value ? (string)rdr["FirstName"] : string.Empty;
                        appointment.SurName = rdr["SurName"] != DBNull.Value ? (string)rdr["SurName"] : string.Empty;
                        appointment.Email = rdr["Email"] != DBNull.Value ? (string)rdr["Email"] : string.Empty;
                        appointment.MobileNo = rdr["MobileNo"] != DBNull.Value ? (string)rdr["MobileNo"] : string.Empty;
                        appointment.PropertyType = rdr["PropertyType"] != DBNull.Value ? (string)rdr["PropertyType"] : string.Empty;
                        appointment.PostCode = rdr["PostCode"] != DBNull.Value ? (string)rdr["PostCode"] : string.Empty;
                        appointment.Address = rdr["Address"] != DBNull.Value ? (string)rdr["Address"] : string.Empty;
                        appointment.NoOfBedrooms = rdr["NoOfBedrooms"] != DBNull.Value ? (string)rdr["NoOfBedrooms"] : string.Empty;
                        appointment.PropertyTypeId = rdr["PropertyTypeId"] != DBNull.Value ? (int)rdr["PropertyTypeId"] : -1;

                        mod = appointment;
                    }
                }
            }
            catch (Exception ex)
            {
                mod = null;
            }
            finally
            {
                con.Close();
            }
            return mod;
        }
        public List<LookUP> GetAllPropertyTypes()
        {
            List<LookUP> list = new List<LookUP>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _conStr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM PropertyType";
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        LookUP propertyType = new LookUP();
                        propertyType.Id = rdr["Id"] != DBNull.Value ? (int)rdr["Id"] : -1;
                        propertyType.Name = rdr["PropertyType"] != DBNull.Value ? (string)rdr["PropertyType"] : string.Empty;

                        list.Add(propertyType);
                    }
                }
            }
            catch (Exception ex)
            {
                list = null;
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public bool DeleteAppointment(int id)
        {
            bool retVal = true;
            SqlConnection con = new SqlConnection(_conStr);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ManageAppointment";
            cmd.Parameters.AddWithValue("@Query", 3);
            cmd.Parameters.AddWithValue("@AppointmentId", id);

            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retVal = false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return retVal;
        }

        #endregion

    }
}
