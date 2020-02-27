import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vHotelDetailBase {

//#region cityName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'cityName', keyColumn: false})
        cityName : string;
//#endregion cityName Prop


//#region cityId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'cityId', keyColumn: true})
        cityId : number;
//#endregion cityId Prop


//#region hotelDetails Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'hotelDetails', keyColumn: false})
        hotelDetails : string;
//#endregion hotelDetails Prop


//#region floors Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'floors', keyColumn: false})
        floors : string;
//#endregion floors Prop


//#region hotelName Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'hotelName', keyColumn: false})
        hotelName : string;
//#endregion hotelName Prop


//#region starCategory Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'starCategory', keyColumn: false})
        starCategory : string;
//#endregion starCategory Prop


//#region userRating Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'userRating', keyColumn: false})
        userRating : string;
//#endregion userRating Prop


//#region hotelId Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'hotelId', keyColumn: false})
        hotelId : number;
//#endregion hotelId Prop


//#region roomType Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'roomType', keyColumn: false})
        roomType : string;
//#endregion roomType Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region checkIn Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'checkIn', keyColumn: false})
        checkIn : any;
//#endregion checkIn Prop


//#region checkOut Prop
        @gridColumn({visible: true, columnIndex:11, allowSorting: true, headerKey: 'checkOut', keyColumn: false})
        checkOut : any;
//#endregion checkOut Prop


//#region travellerId Prop
        @gridColumn({visible: true, columnIndex:12, allowSorting: true, headerKey: 'travellerId', keyColumn: false})
        travellerId : number;
//#endregion travellerId Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:13, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @gridColumn({visible: true, columnIndex:14, allowSorting: true, headerKey: 'lastName', keyColumn: false})
        lastName : string;
//#endregion lastName Prop

}