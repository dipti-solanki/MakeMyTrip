import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BusBookingBase {

//#region busBookingId Prop
        @prop()
        busBookingId : number;
//#endregion busBookingId Prop


//#region travellerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        travellerId : number;
//#endregion travellerId Prop


//#region busDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        busDetailId : number;
//#endregion busDetailId Prop


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