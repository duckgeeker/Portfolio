Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMathService" in both code and config file together.
<ServiceContract()>
Public Interface IMathService

    <OperationContract()>
    Sub DoWork()

End Interface
