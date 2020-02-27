import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BusBase {

//#region busId Prop
        @prop()
        busId : number;
//#endregion busId Prop


//#region busName Prop
        @required()
        @maxLength({value:50})
        busName : string;
//#endregion busName Prop



}