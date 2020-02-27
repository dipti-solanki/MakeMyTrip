import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TrainBookingBase {

//#region trainBookingId Prop
        @prop()
        trainBookingId : number;
//#endregion trainBookingId Prop


//#region travellerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        travellerId : number;
//#endregion travellerId Prop


//#region trainDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        trainDetailId : number;
//#endregion trainDetailId Prop


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