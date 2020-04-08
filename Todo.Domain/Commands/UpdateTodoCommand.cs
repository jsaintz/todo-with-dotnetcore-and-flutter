using  System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable, ICommand
    {
        public UpdateTodoCommand()
        {
        }
        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string User { get; private set; }

        public void Validate()
        {
           AddNotifications(
               new Contract()
               .Requires()
               .HasMinLen(Title, 3,"Title", "Por favor, descreva melhor esta tarefa!")
               .HasMinLen(User, 6, "User", "Usuário inválido!")
           );
        }
    }
}