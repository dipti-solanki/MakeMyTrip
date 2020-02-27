import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TrainDetailBase {

//#region trainDetailId Prop
        @prop()
        trainDetailId : number;
//#endregion trainDetailId Prop


//#region trainId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        trainId : number;
//#endregion trainId Prop


//#region trainDetails Prop
        @required()
        @maxLength({value:50})
        trainDetails : string;
//#endregion trainDetails Prop


//#region class Prop
        @required()
        @maxLength({value:50})
        class : string;
//#endregion class Prop


//#region origin Prop
        @required()
        @maxLength({value:50})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @required()
        @maxLength({value:50})
        destination : string;
//#endregion destination Prop


//#region date Prop
        @required()
        date : any;
//#endregion date Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop





}