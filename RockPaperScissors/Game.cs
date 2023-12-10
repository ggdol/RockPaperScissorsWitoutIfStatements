using System.Text.RegularExpressions;

namespace RockPaperScissors
{
    public class Game
    {
        public static Dictionary<(PlayerMoves, PlayerMoves), Outcomes> movementResult = new(){

            {(PlayerMoves.Spock, PlayerMoves.Scissors), Outcomes.Smashes},
            {(PlayerMoves.Paper, PlayerMoves.Spock), Outcomes.Disproves},
            {(PlayerMoves.Rock, PlayerMoves.Lizard), Outcomes.Crushes},
            {(PlayerMoves.Lizard, PlayerMoves.Spock), Outcomes.Poisons},
            {(PlayerMoves.Scissors, PlayerMoves.Lizard), Outcomes.Decapitates},
            {(PlayerMoves.Lizard, PlayerMoves.Paper), Outcomes.Eats},
            {(PlayerMoves.Spock, PlayerMoves.Rock), Outcomes.Vaporizes}
            };
        public object Play(PlayerMoves PlayerMove, PlayerMoves opponetMove)
        {

            return movementResult.ContainsKey((PlayerMove, opponetMove)) ? movementResult.GetValueOrDefault((PlayerMove, opponetMove)) : Outcomes.PlayerLoses;
        }
    }

    public enum PlayerMoves
    {

        Paper,
        Rock,
        Scissors,
        Spock,
        Lizard
    }

    public enum Outcomes
    {

        PlayerLoses,
        PlayerWins,
        Tie,
        Crushes,
        Eats,
        Decapitates,
        Poisons,
        Vaporizes,
        Disproves,
        Smashes
    }
}