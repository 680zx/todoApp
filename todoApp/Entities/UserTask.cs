using System;

namespace Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime NotificationTime { get; set; }
    }
}