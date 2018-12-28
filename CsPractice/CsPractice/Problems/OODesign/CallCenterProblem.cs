using System;
using System.Collections.Generic;
using System.Linq;

namespace CsPractice.Problems.OODesign
{
    class CallCenterProblem
    {
    }

    public class CallHandler
    {
        private Queue<Call> incomingCalls;
        private Queue<Call> directorCalls;
        private Queue<Respondent> level1Responders;
        private Queue<Respondent> level2Responders;
        private Queue<Director> level3Responders;

        public CallHandler()
        {
            incomingCalls = new Queue<Call>();
            directorCalls = new Queue<Call>();
            level1Responders = new Queue<Respondent>();
            level2Responders = new Queue<Respondent>();
            level3Responders = new Queue<Director>();
        }

        public void AddRespondent(Respondent respondent)
        {
            respondent.Escalation += EscalateToManager;
            if (incomingCalls.Any())
            {
                AssignCall(respondent, incomingCalls.Dequeue());
            }
            else
            {
                level1Responders.Enqueue(respondent);
            }
        }

        public void RemoveRespondent(Respondent respondent)
        {
            respondent.Escalation -= EscalateToManager;
        }

        public void AddManager(Respondent manager)
        {
            manager.Escalation += EscalateToDirector;
            level2Responders.Enqueue(manager);
        }

        public void RemoveManager(Respondent manager)
        {
            manager.Escalation -= EscalateToDirector;
        }

        public void AddDirector(Director director)
        {
            if (directorCalls.Any())
            {
                AssignCall(director, directorCalls.Dequeue());
            }
            else
            {
                level3Responders.Enqueue(director);
            }
        }

        public void DispatchCall(Call call)
        {
            if (level1Responders.Any())
            {
                AssignCall(level1Responders.Dequeue(), call);
            }
            else
            {
                incomingCalls.Enqueue(call);
            }
        }

        private void AssignCall(Employee assignee, Call call)
        {
            assignee.TakeCall(call);
        }

        private void EscalateToManager(object sender, EscalationEventArgs e)
        {
            if (level2Responders.Any())
            {
                AssignCall(level2Responders.Dequeue(), e.call);
            }
            else
            {
                EscalateToDirector(sender, e);
            }
        }

        private void EscalateToDirector(object sender, EscalationEventArgs e)
        {
            if (level3Responders.Any())
            {
                AssignCall(level3Responders.Dequeue(), e.call);
            }
            else
            {
                directorCalls.Enqueue(e.call);
            }
        }
    }

    public abstract class Employee
    {
        public bool IsAvailable { get; private set; }
        public bool IsEndOfShift { get; set; }
        protected Call currentCall;
        private bool isEndOfShift;

        public void TakeCall(Call call)
        {
            currentCall = call;
            IsAvailable = false;
        }

        public void CompleteCall()
        {
            currentCall = null;
            if (!IsEndOfShift)
            {
                IsAvailable = true;
            }
        }
    }

    public class Respondent : Employee
    {
        public event EventHandler<EscalationEventArgs> Escalation;

        public void Escalate()
        {
            EscalationEventArgs args = new EscalationEventArgs();
            args.call = currentCall;
            Escalation(this, new EscalationEventArgs());
            CompleteCall();
        }
    }

    public class Director : Employee
    {
    }

    public class Call
    {
    }

    public class EscalationEventArgs : EventArgs
    {
        public Call call;
    }
}
