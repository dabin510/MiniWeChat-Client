//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GroupData.proto
// Note: requires additional types generated from: UserData.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GroupItem")]
  public partial class GroupItem : global::ProtoBuf.IExtensible
  {
    public GroupItem() {}
    
    private string _groupId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"groupId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string groupId
    {
      get { return _groupId; }
      set { _groupId = value; }
    }
    private string _groupName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"groupName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string groupName
    {
      get { return _groupName; }
      set { _groupName = value; }
    }
    private protocol.UserItem _creater;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"creater", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public protocol.UserItem creater
    {
      get { return _creater; }
      set { _creater = value; }
    }
    private readonly global::System.Collections.Generic.List<protocol.UserItem> _memberUser = new global::System.Collections.Generic.List<protocol.UserItem>();
    [global::ProtoBuf.ProtoMember(4, Name=@"memberUser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<protocol.UserItem> memberUser
    {
      get { return _memberUser; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}