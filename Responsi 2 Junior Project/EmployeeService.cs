using Npgsql;
using Responsi_2_Junior_Project;
using System.Data;

public class EmployeeService
{
    private readonly DbContext _dbContext;

    public EmployeeService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<DataTable> GetAllEmployeesAsync()
    {
        const string sql = @"
        SELECT k.id_karyawan, k.nama, k.id_dep, d.nama_dep 
        FROM public.karyawan k 
        LEFT JOIN public.departemen d ON k.id_dep = d.id_dep
        ORDER BY k.id_karyawan";

        using var conn = _dbContext.GetConnection();
        await conn.OpenAsync();

        using var cmd = new NpgsqlCommand(sql, conn);
        var adapter = new NpgsqlDataAdapter(cmd);
        var dataTable = new DataTable();
        adapter.Fill(dataTable);

        return dataTable;
    }

    public async Task AddEmployeeAsync(Employee employee)
    {
        const string sql = @"
        INSERT INTO public.karyawan (nama, id_dep) 
        VALUES (@nama, @idDep)";

        using var conn = _dbContext.GetConnection();
        await conn.OpenAsync();

        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@nama", employee.Name);
        cmd.Parameters.AddWithValue("@idDep", employee.DepartmentId);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        const string sql = @"
        UPDATE public.karyawan 
        SET nama = @nama, id_dep = @idDep 
        WHERE id_karyawan = @idKaryawan";

        using var conn = _dbContext.GetConnection();
        await conn.OpenAsync();

        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@nama", employee.Name);
        cmd.Parameters.AddWithValue("@idDep", employee.DepartmentId);
        cmd.Parameters.AddWithValue("@idKaryawan", employee.Id);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task DeleteEmployeeAsync(string employeeId)
    {
        const string sql = "DELETE FROM public.karyawan WHERE id_karyawan = @idKaryawan";

        using var conn = _dbContext.GetConnection();
        await conn.OpenAsync();

        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@idKaryawan", employeeId);

        await cmd.ExecuteNonQueryAsync();
    }
}