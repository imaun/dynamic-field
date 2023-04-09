namespace ImanN.DynamicFields.Contracts;

public interface IDynamicFieldDbContext
{

    void BeginTransaction();

    Task BeginTransactionAsync(CancellationToken cancellationToken = default);

    void RollbackTransaction();

    Task RollbackTransactionAsync(CancellationToken cancellationToken = default);

    void CommitTransaction();

    Task CommitTransactionAsync(CancellationToken cancellationToken = default);

    int SaveChanges();

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    void ExecuteSqlCommand(string sql, params object[] parameters);

    Task ExecuteSqlCommandAsync(string sql, params object[] parameter);

    bool EnsureDbCreated();

    Task<bool> EnsureDbCreatedAsync(CancellationToken cancellationToken = default);

    void MigrateDb();

    Task MigrateDbAsync(CancellationToken cancellationToken = default);
    
}