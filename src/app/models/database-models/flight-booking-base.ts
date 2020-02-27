import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class FlightBookingBase {

//#region flightBookingId Prop
        @prop()
        flightBookingId : number;
//#endregion flightBookingId Prop


//#region travellerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        travellerId : number;
//#endregion travellerId Prop


//#region flightDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        flightDetailId : number;
//#endregion flightDetailId Prop


//#region offerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        offerId : number;
//#endregion offerId Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop



}