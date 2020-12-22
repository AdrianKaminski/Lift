using System;
using System.Collections.Generic;
using System.Linq;

namespace Lift.Core.Domain
{
    public class DailyRoute
    {
        private ISet<PassengerNode> _passengerNodes = new HashSet<PassengerNode>();
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<PassengerNode> PassengerNodes
        {
            get { return _passengerNodes; }
            set { _passengerNodes = new HashSet<PassengerNode>(value); }
        }

        protected DailyRoute()
        {
        }

        public void AddPassengerNode(Passenger passenger, Node node)
        {
            var passengerNode = GetPassengerNode(passenger);
            if(passengerNode != null)
            {
                throw new InvalidOperationException($"Node already exists for passenger: '{passenger.UserId}'.");
            }
            _passengerNodes.Add(PassengerNode.Create(passenger, node));
        }

        public void RemovePassengerNode(Passenger passenger)
        {
            var passengerNode = GetPassengerNode(passenger);
            if(passengerNode == null)
            {
                return;
            }
            _passengerNodes.Remove(passengerNode);
        } 

        private PassengerNode GetPassengerNode(Passenger passenger)
            => _passengerNodes.SingleOrDefault(x => x.Passenger.UserId == passenger.UserId);
    }
}