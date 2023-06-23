namespace NetworkManager2.Models
{
    public interface ISwitchAdapter
    {
        bool Connected { get; }
        void Close();
        Boolean isConnected();
        Dictionary<int, string> GetVlans();
        Dictionary<int, string> GetAllPortStates();
        String GetPortState(int portId);
        Dictionary<int, int> GetAllPortVlans();
        int GetPortVlan(int portId);
        List<int> GetPortTaggedVlans(int portId);
        void SetPortVlan(int portId, int vlanId);
        Dictionary<int, string> GetAllPortNames();
        string GetPortDescription(int portId);
        void SetPortDescription(int portId, string description);
        String GetSystemName();
        void SetSystemName(string name);
        String GetLocation();
        void SetLocation(string location);
        String GetModelName();
        Dictionary<String, String> GetSystemInfo();
        Dictionary<int, Dictionary<string, string>> GetAllLldpRemoteDevices();
        Dictionary<string, string> GetLldpRemoteDevice(int portId);


    }
}
