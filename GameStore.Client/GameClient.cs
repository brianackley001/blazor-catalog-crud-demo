using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
  {
    new Game()
    {
      ID = 1,
      Name = "Halo",
      Genre = "FPS",
      ReleaseDate = new DateTime(2001, 11, 15),
      Price = 49.99M
    },
    new Game()
    {
      ID = 2,
      Name = "Street Fighter II",
      Genre = "Fighting",
      ReleaseDate = new DateTime(1991, 11, 9),
      Price = 19.99M
    },
    new Game()
    {
      ID = 3,
      Name = "Super Mario Bros.",
      Genre = "RolePlaying",
      ReleaseDate = new DateTime(1985, 9, 13),
      Price = 29.99M
    },
    new Game()
    {
      ID = 4,
      Name = "The Legend of Zelda",
      Genre = "RolePlaying",
      ReleaseDate = new DateTime(1986, 2, 21),
      Price = 39.99M
    },
    new Game()
    {
      ID = 5,
      Name = "Fifa",
      Genre = "Sports",
      ReleaseDate = new DateTime(1999, 4, 21),
      Price = 39.99M
    }
  };
  public static Game[] GetGames()
  {
    return games.ToArray();
  }
  public static void AddGame(Game game)
  {
    game.ID = games.Max(g => g.ID) + 1;
    games.Add(game);
  }
  public static Game GetGame(int id)
  {
    return games.FirstOrDefault(g => g.ID == id) ?? throw new ArgumentException("Could not find game.");
  }
  public static void UpdateGame(Game game)
  {
    Game existingGame = GetGame(game.ID);
    existingGame.Name = game.Name;
    existingGame.Genre = game.Genre;
    existingGame.Price = game.Price;
    existingGame.ReleaseDate = game.ReleaseDate;
  }
  public static void DeleteGame(int id)
  {
    Game game = GetGame(id);
    games.Remove(game);
  }
}