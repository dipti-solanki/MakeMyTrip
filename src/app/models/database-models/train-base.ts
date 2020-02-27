import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TrainBase {

//#region trainId Prop
        @prop()
        trainId : number;
//#endregion trainId Prop


//#region trainName Prop
        @required()
        @maxLength({value:50})
        trainName : string;
//#endregion trainName Prop



}