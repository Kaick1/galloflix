namespace GalloFlix.Interfaces;

public interface IRepository<T> where T : class
{
    //CRUD: Create, Read, Update, Delete

    //CREATE - Adicionar novo dado
    void Create(T model);

    //READ - Leitura de Dados
    List<T> ReadAll();
    T ReadById(int? id);

    //UPDATE - Atualizar Dados
    void Update(T model);

    //DELETAR - Deletar Dados
    void Delete(int? id);
}