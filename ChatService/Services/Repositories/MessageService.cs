﻿using ChatService.Models;
using ChatService.Services.Interfaces;

namespace ChatService.Services.Repositories
{
    public class MessageService : IMessageService
    {
        private int _counter = 1000;
        private Dictionary<int, Client> _clients = new Dictionary<int, Client>();

        public int AddClient(string name)
        {
            lock (_clients)
            {
                _clients[++_counter] = new Client
                {
                    Id = _counter,
                    Name = name,
                };
            }

            return _counter;
        }
    }
}
