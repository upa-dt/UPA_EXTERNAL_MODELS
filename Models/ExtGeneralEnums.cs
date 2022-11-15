
/// <summary>
/// <remarks>
/// Product Category 
/// <ol>
/// <li>Drug Product Type</li>
/// <li>Device Product Type</li>
///  <li>Lab Product Type</li>
///  <li>Supply Product Type</li>
/// </ol> 
/// </remarks>
/// </summary>
public enum ProductTypeEnum { Drugs = 1, Devices = 2, Labs = 3, Supplies = 4 }

/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>1</td>
///        <td>محجوزة للتدوير</td>
///    </tr>
///    <tr>
///        <td>2</td>
///        <td>عهدة مخزن</td>
///    </tr>
///   <tr>
///        <td>3</td>
///        <td>تحت الفحص</td>
///    </tr>
///    <tr>
///        <td>4</td>
///        <td>عهدة مورد</td>
///    </tr>
///    <tr>
///        <td>5</td>
///        <td>عهدة خارجية</td>
///    </tr>
///    <tr>
///        <td>6</td>
///        <td>عهدة نهائية</td>
///    </tr>
///    <tr>
///        <td>7</td>
///        <td>عهدة مرتجع فحص</td>
///    </tr>
///    <tr>
///        <td>8</td>
///        <td>محجوزة صرف خارجى</td>
///    </tr>
///    <tr>
///       <td>9</td>
///        <td>عهدة مرتجع صلاحية</td>
///    </tr>
///</table>
/// </summary>
public enum CustodyTypeEnum
{
    LOCKED_FOR_TRANSACTION = 1,
    WAREHOUSE_CUSTDY = 2,
    UNDER_INSPECTION = 3,
    VENDOR_CUSTDY = 4,
    EXTERNAL_CUSTDY = 5,
    FINAL_CUSTDY = 6,
    RETURN_CUSTDY = 7,
    EXTERNAL_WITHDRAW = 8,
    RETURN_EXPIRY = 9
}

/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr>
///    <tr>
///        <td>4</td>
///        <td>إستهلاك جهة</td>
///    </tr>
///    <tr>
///        <td>5</td>
///        <td>طلب تدوير عهدة</td>
///    </tr>
///   <tr>
///        <td>6</td>
///        <td>تدوير عهدة</td>
///    </tr>
///    <tr>
///        <td>7</td>
///        <td>إلغاء طلب تدوير عهدة</td>
///    </tr>
///    <tr>
///        <td>8</td>
///        <td>إضافة شراء مباشر - عهدة خارجية</td>
///    </tr>
///    <tr>
///        <td>11</td>
///        <td>طلب صرف خارجى</td>
///    </tr>
///    <tr>
///        <td>12</td>
///        <td>صرف خارجى</td>
///    </tr>
///    <tr>
///        <td>13</td>
///        <td>إلغاء طلب صرف خارجى</td>
///    </tr>
///    <tr>
///       <td>14</td>
///        <td>طلب إرتجاع صلاحية</td>
///    </tr>
///    <tr>
///       <td>15</td>
///        <td>إرتجاع صلاحية</td>
///    </tr>
///    <tr>
///       <td>16</td>
///        <td>إلغاء طلب إرتجاع</td>
///    </tr>
///    <tr>
///       <td>17</td>
///        <td>إرتجاع عهدة مرفوض الفحص</td>
///    </tr> 
///</table>
/// </summary>
public enum TransactionTypeEnum
{
    ENTITY_CONSUMPTION = 4,
    CUSTODY_STAGINATION_REQUEST = 5,
    CUSTODY_RECYCLE_EXEC = 6,
    CUSTODY_RECYCLE_REQUEST_CANCEL = 7,
    EXTERNAL_PROCUREMENT_ADDITION = 8,
    EXTERNAL_WITHDRAW_REQUEST = 11,
    EXTERNAL_WITHDRAW_EXEC = 12,
    EXTERNAL_WITHDRAW_REQUEST_CANCEL = 13,
    RETURN_EXPIRY_REQUEST = 14,
    RETURN_EXPIRY_EXEC = 15,
    RETURN_EXPIRY_REQUEST_CANCEL = 16,
    FINAL_REJECTION_EXECUTION = 17
}

/// <summary>
///<table>
///    <tr>
///        <td>Code</td>
///        <td>Name</td>
///    </tr> 
///   <tr>
///        <td>3</td>
///        <td>جديد</td>
///    </tr>
///    <tr>
///        <td>4</td>
///        <td>تسلبم جزئى</td>
///    </tr>
///    <tr>
///        <td>5</td>
///        <td>تم التسليم بالكامل</td>
///    </tr> 
///</table>
/// </summary>
public enum PoStatusEnum
{
    NEW = 3,
    PARTIAL_DELIVERED = 4,
    FULL_DELIVERED = 5,
}