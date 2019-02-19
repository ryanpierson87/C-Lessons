using System;
namespace Interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
