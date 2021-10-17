using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Orderio.Web.WebSockets
{
    public class ConnectionManager
    {
        private ConcurrentDictionary<int, List<Connection>> _connections = new ConcurrentDictionary<int, List<Connection>>();

        public List<Connection> GetUserConnections(int id) => _connections.ContainsKey(id) ? _connections.FirstOrDefault(x => x.Key == id).Value : null;

        public void AddConnection(int userId, Connection connection)
        {
            if (_connections.ContainsKey(userId))
                _connections[userId].Add(connection);
            else
                _connections.TryAdd(userId, new List<Connection> { connection });
        }

        public async Task CloseConnectionAsync(string accessToken)
        {
            var userConnections = _connections.FirstOrDefault(x => x.Value.FirstOrDefault(x => x.AccessToken == accessToken) != null);
            var currentConnection = userConnections.Value.FirstOrDefault(x => x.AccessToken == accessToken);
            if (_connections[userConnections.Key].Count > 1)
            {
                _connections[userConnections.Key].Remove(currentConnection);
                await currentConnection.WebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", System.Threading.CancellationToken.None);
            }
            else
            {
                _connections.Remove(userConnections.Key, out var connections);
            }
        }
    }
}