

/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>1</td>
///        <td>National ID</td>
///    </tr>
///    <tr>
///        <td>2</td>
///        <td>Passport</td>
///    </tr> 
///</table>
/// </summary>
public enum IDTypeEnum { NationalID = 1, Passport = 2 }
/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>1</td>
///        <td>Male</td>
///    </tr>
///    <tr>
///        <td>2</td>
///        <td>Female</td>
///    </tr> 
///</table>
/// </summary>
public enum GenderEnum { Male = 1, Female = 2 }

/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>1</td>
///        <td>Add</td>
///    </tr>
///    <tr>
///        <td>2</td>
///        <td>Subtract</td>
///    </tr> 
///    <tr>
///        <td>3</td>
///        <td>Set-Value</td>
///    </tr> 
///</table>
/// </summary>
public enum BloodTransactionTypeEnum { Add = 1, SUBTRACT = 2, SET_VALUE = 3 }



/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>1</td>
///        <td>Free To Use</td>
///    </tr>
///    <tr>
///        <td>2</td>
///        <td>Reserved-For-surgery</td>
///    </tr> 
///    <tr>
///        <td>3</td>
///        <td>Destroyed</td>
///    </tr> 
///</table>
/// </summary>
public enum BloodInventoryTypeEnum { FreeToUse = 1, Reserved_For_surgery = 2, Destroyed = 3 }