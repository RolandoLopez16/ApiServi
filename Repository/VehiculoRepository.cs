using Dapper;
using Microsoft.Data.Sqlite;
using System;
using Microsoft.Extensions.Configuration;
using APISERVI.Models;
using APISERVI.Repository.Application;


namespace APISERVI.Repository
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly string? _connectionString;

        public VehiculoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Sqlite");
        }

        public async Task<int> AddAsync(Vehiculo entity)
        {
            var sql = "INSERT INTO Vehiculos (Placa, NoOrden, Capacidad, IdEstado) VALUES (@Placa, @NoOrden, @Capacidad, @IdEstado)";
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Vehiculos WHERE IdVehiculo = @Id";
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IEnumerable<Vehiculo>> GetAllAsync()
        {
            var sql = "SELECT * FROM Vehiculos";
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Vehiculo>(sql);
                return result;
            }
        }

        public async Task<Vehiculo> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Vehiculos WHERE IdVehiculo = @Id";
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Vehiculo>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Vehiculo entity)
        {
            var sql = "UPDATE Vehiculos SET Placa = @Placa, NoOrden = @NoOrden, Capacidad = @Capacidad, IdEstado = @IdEstado WHERE IdVehiculo = @IdVehiculo";
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}
