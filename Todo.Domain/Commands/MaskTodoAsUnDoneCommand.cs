using  System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUnDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsUnDoneCommand(){}
        public MarkTodoAsUnDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id {get; set;}
        public string User {get; set;}
        
        public void Validate()
        {
           AddNotifications(
               new Contract()
               .Requires()
               .HasMinLen(User, 6, "User", "Usuário invalido!")
           );
        }
    }
}