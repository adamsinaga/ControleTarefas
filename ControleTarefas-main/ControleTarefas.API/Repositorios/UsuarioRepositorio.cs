using ControleTarefas.API.Data;
using ControleTarefas.API.Models;
using ControleTarefas.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    private readonly ControleTarefasDBContext _dbContext;
    public UsuarioRepositorio(ControleTarefasDBContext controleTarefasDBContext)
    {
        _dbContext = controleTarefasDBContext;
    }

    public async Task<Usuario> Adicionar(Usuario usuario)
    {
        await _dbContext.Usuarios.AddAsync(usuario);
        await _dbContext.SaveChangesAsync();
        return usuario;
    }

    public async Task<bool> Apagar(int id)
    {
        Usuario usuarioPorId = await BuscarPorId(id);
        if (usuarioPorId == null) throw new Exception("Usuário para o Id " + id.ToString() + " não foi encontrado.");

        _dbContext.Usuarios.Remove(usuarioPorId);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<Usuario> Atualizar(Usuario usuario, int id)
    {
        Usuario usuarioPorId = await BuscarPorId(id);
        if (usuarioPorId == null) throw new Exception("Usuário para o Id " + id.ToString() + " não foi encontrado.");

        usuarioPorId.Login = usuario.Login;
        usuarioPorId.Senha = usuario.Senha;
        usuarioPorId.TipoSenha = usuario.TipoSenha;

        _dbContext.Usuarios.Update(usuarioPorId);
        await _dbContext.SaveChangesAsync();

        return usuarioPorId;
    }

    public async Task<Usuario> BuscarPorId(int id)
    {
        return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);
    }

    public async Task<List<Usuario>> BuscarTodosUsuarios()
    {
        return await _dbContext.Usuarios.ToListAsync();
    }
}