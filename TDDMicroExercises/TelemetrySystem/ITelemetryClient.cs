using System;

namespace TDDMicroExercises.TelemetrySystem
{
    public interface ITelemetryClient
    {

        void Connect(string telemetryServerConnectionString);

        void Disconnect();

        void Send(string message);

        string Receive();
        bool OnlineStatus();
    }
}
