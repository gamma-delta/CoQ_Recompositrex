using XRL;
using XRL.Core;
using XRL.World;

[HasCallAfterGameLoadedAttribute]
public class MyClass {
  [CallAfterGameLoadedAttribute]
  public static void MyCallback() {
    XRL.Messages.MessageQueue.AddPlayerMessage("Hello, world! This is Recompositrex!");
  }
}