import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class RoomBase {

//#region roomId Prop
        @prop()
        roomId : number;
//#endregion roomId Prop


//#region hotelDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        hotelDetailId : number;
//#endregion hotelDetailId Prop


//#region roomType Prop
        @required()
        @maxLength({value:50})
        roomType : string;
//#endregion roomType Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop


//#region checkIn Prop
        @required()
        checkIn : any;
//#endregion checkIn Prop


//#region checkOut Prop
        @required()
        checkOut : any;
//#endregion checkOut Prop



}