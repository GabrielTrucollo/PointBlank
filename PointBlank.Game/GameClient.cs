﻿namespace PointBlank.Game
{
    using System.Net.Sockets;
    using System.Reflection;
    using OR.Game;
    using OR.Game.Packets.Ack;

    public class GameClient : BaseClient
    {
        #region Construtor
        /// <summary>
        /// Inicia uma nova instancia da classe <see cref="GameClient"/>
        /// </summary>
        /// <param name="tcpClient">Sessão criada para a conexão</param>
        /// <param name="sessionId">SessionId da conexao</param>
        /// <param name="showHex">Se true indica que é para mostrar os hex recebidos</param>
        public GameClient(TcpClient tcpClient, uint sessionId, bool showHex)
            : base(tcpClient, sessionId, showHex)
        {
        }
        #endregion

        #region Métodos
        /// <inheritdoc/>
        protected override Assembly ObterAssemblyAtual()
        {
            return typeof(PROTOCOL_SERVER_MESSAGE_CONNECTIONSUCCESS_ACK).Assembly;
        }
        #endregion
    }
}